import { useCallback, useEffect, useRef, useState } from 'react';

import { ReactP5Wrapper, Sketch, SketchProps } from '@p5-wrapper/react';
import { Panel, PanelGroup, PanelResizeHandle } from 'react-resizable-panels';
import './App.scss';
import Planet from './Planet';

interface MySketchProps extends SketchProps {
  size: { width: number; height: number; };
  planets: Planet[];
}

const fps = 30;

const p5sketch: Sketch<MySketchProps> = (p5) => {
  let
    sun: any,
    mercury: any,
    venus: any,
    earth: any,
    mars: any,
    jupiter: any,
    saturn: any,
    uranus: any,
    neptune: any,
    pluto: any;

  let size: MySketchProps['size'] = { width: 0, height: 0 };
  let planets: MySketchProps['planets'] = [];
  let diameter = { limit: 0, min: 0, max: 0 };

  p5.preload = () => {
    sun = p5.loadImage('images/sun.png');
    mercury = p5.loadImage('images/mercury.png');
    venus = p5.loadImage('images/venus.png');
    earth = p5.loadImage('images/earth.png');
    mars = p5.loadImage('images/mars.png');
    jupiter = p5.loadImage('images/jupiter.png');
    saturn = p5.loadImage('images/saturn.png');
    uranus = p5.loadImage('images/uranus.png');
    neptune = p5.loadImage('images/neptune.png');
    pluto = p5.loadImage('images/pluto.png');
  };

  p5.setup = () => {
    p5.createCanvas(p5.windowWidth, p5.windowHeight);
    p5.frameRate(fps);
    p5.imageMode(p5.CENTER);
  };

  p5.updateWithProps = (props: MySketchProps) => {
    size = props.size;
    planets = props.planets;
    diameter = {
      limit: (size.width < size.height ? size.width : size.height) * 0.9,
      min: planets.reduce((prev, cur) => (cur.diameter < prev.diameter ? cur : prev)).diameter,
      max: planets.reduce((prev, cur) => (cur.diameter > prev.diameter ? cur : prev)).diameter,
    };
  };

  p5.draw = () => {
    if (p5.width !== size.width || p5.height !== size.height) {
      p5.resizeCanvas(size.width, size.height);
    }

    p5.translate(p5.width * 0.5, p5.height * 0.5);
    p5.background(0);

    p5.noStroke();
    p5.fill(255);
    p5.image(sun, 0, 0, diameter.limit * 0.13, diameter.limit * 0.13);

    for (const [i, planet] of planets.entries()) {
      const radius = p5.map(i, 0, planets.length, diameter.limit * 0.1, diameter.limit * 0.57);
      const angle = p5.TWO_PI * planet.orbit;
      const x = radius * p5.sin(angle);
      const y = radius * p5.cos(angle);
      const d = p5.map(planet.diameter, diameter.min, diameter.max, diameter.limit * 0.025, diameter.limit * 0.05);

      p5.noFill();
      p5.stroke(255);
      p5.strokeWeight(1);
      p5.circle(0, 0, radius * 2);

      switch (planet.name) {
        case 'Merkurius':
          p5.image(mercury, x, y, d, d);
          break;
        case 'Venus':
          p5.image(venus, x, y, d, d);
          break;
        case 'Bumi':
          p5.image(earth, x, y, d, d);
          break;
        case 'Mars':
          p5.image(mars, x, y, d, d);
          break;
        case 'Jupiter':
          p5.image(jupiter, x, y, d, d);
          break;
        case 'Saturnus':
          p5.image(saturn, x, y, d * 2.5, d * 1.33);
          break;
        case 'Uranus':
          p5.image(uranus, x, y, d, d);
          break;
        case 'Neptunus':
          p5.image(neptune, x, y, d, d);
          break;
        case 'Pluto':
          p5.image(pluto, x, y, d, d);
          break;
      }

      if (planet.showSight) {
        const off = d * 0.55;
        const len = d * 0.2;
        p5.stroke(64, 255, 64);
        p5.strokeWeight(2);
        p5.line(x - off, y - off, x - off + len, y - off);
        p5.line(x + off, y - off, x + off - len, y - off);
        p5.line(x + off, y - off, x + off, y - off + len);
        p5.line(x + off, y + off, x + off, y + off - len);
        p5.line(x + off, y + off, x + off - len, y + off);
        p5.line(x - off, y + off, x - off + len, y + off);
        p5.line(x - off, y - off, x - off, y - off + len);
        p5.line(x - off, y + off, x - off, y + off - len);

        p5.fill(255);
        p5.noStroke();
        p5.textSize(48);
        p5.text(planet.name, (p5.width * -0.5) + 10, (p5.height * -0.5) + 50);
      }
    }
  };
}

const planets = [
  new Planet(fps, 'Merkurius', 0.330, 4879, 3.7, 1407.6, 57.9, 88.0),
  new Planet(fps, 'Venus', 4.87, 12104, 8.9, -5832.5, 108.2, 224.7),
  new Planet(fps, 'Bumi', 5.97, 12756, 9.8, 23.9, 149.6, 365.2),
  new Planet(fps, 'Mars', 0.642, 6792, 3.7, 24.6, 228.0, 687.0),
  new Planet(fps, 'Jupiter', 1898, 142984, 23.1, 9.9, 778.5, 4331),
  new Planet(fps, 'Saturnus', 568, 120536, 9.0, 10.7, 1432.0, 10747),
  new Planet(fps, 'Uranus', 86.8, 51118, 8.7, -17.2, 2867.0, 30589),
  new Planet(fps, 'Neptunus', 102, 49528, 11.0, 16.1, 4515.0, 59800),
  new Planet(fps, 'Pluto', 0.0130, 2376, 0.7, -153.3, 5906.4, 90560),
];

export default function App() {
  const p5container = useRef<HTMLDivElement>(null);
  const [p5size, setP5size] = useState<MySketchProps['size']>({ width: 0, height: 0 })

  const resize = useCallback(() => {
    if (p5container.current) {
      setP5size({
        width: p5container.current.clientWidth,
        height: p5container.current.clientHeight,
      });
    }
  }, [p5container]);

  useEffect(() => {
    window.addEventListener('resize', resize);
    return () => window.removeEventListener('resize', resize);
  }, [resize]);

  return (
    <div className="vw-100 vh-100">
      <PanelGroup
        autoSaveId="main-panel"
        direction="horizontal"
        onLayout={resize}
        style={{ backgroundColor: 'black' }}
      >
        <Panel minSize={50}>
          <div
            ref={p5container}
            className="w-100 h-100"
          >
            <ReactP5Wrapper
              sketch={p5sketch}
              size={p5size}
              planets={planets}
            />
          </div>
        </Panel>
        <PanelResizeHandle>
          +
        </PanelResizeHandle>
        <Panel
          minSize={25}
          defaultSize={33}
          className="bg-light d-flex flex-column"
        >
          <div className="p-2">
            <div className="fs-4 fw-medium">
              Fajar Nur Prasetyo
            </div>
            <div>
              TI.S1.P.22.0.SWN
            </div>
            <div>
              1122100007
            </div>
          </div>
          <div className="flex-grow-1 overflow-auto">
            <table className="table table-hover table-bordered user-select-none">
              <thead>
                <tr className="table-dark text-center text-nowrap align-middle">
                  <th>Planet</th>
                  <th>Massa<br /><small>(10<sup>24</sup> kg)</small></th>
                  <th>Diameter<br /><small>(km)</small></th>
                  <th>Gravitasi<br /><small>(m/s<sup>2</sup>)</small></th>
                  <th>Jarak ke matahari<br /><small>(10<sup>6</sup> km)</small></th>
                  <th>Periode Rotasi<br /><small>(jam)</small></th>
                  <th>Periode Orbital<br /><small>(hari)</small></th>
                </tr>
              </thead>
              <tbody>
                {planets.map((planet) => (
                  <tr
                    key={planet.name}
                    style={{ cursor: 'pointer' }}
                    onMouseEnter={() => planet.showSight = true}
                    onMouseLeave={() => planet.showSight = false}
                  >
                    <td>{planet.name}</td>
                    <td align="center">{planet.mass}</td>
                    <td align="center">{planet.diameter}</td>
                    <td align="center">{planet.gravity}</td>
                    <td align="center">{planet.distanceFromSun}</td>
                    <td align="center">{planet.rotationPeriod}</td>
                    <td align="center">{planet.orbitalPeriod}</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </Panel>
      </PanelGroup>
    </div>
  );
}
