export default class Planet {
  readonly fps: number;
  readonly name: string;
  readonly mass: number;
  readonly diameter: number;
  readonly gravity: number;
  readonly rotationPeriod: number;
  readonly distanceFromSun: number;
  readonly orbitalPeriod: number;
  showSight = false;

  constructor(
    fps: number,
    name: string,
    mass: number,
    diameter: number,
    gravity: number,
    rotationPeriod: number,
    distanceFromSun: number,
    orbitalPeriod: number,
  ) {
    this.fps = fps;
    this.name = name;
    this.mass = mass;
    this.diameter = diameter;
    this.gravity = gravity;
    this.rotationPeriod = rotationPeriod;
    this.distanceFromSun = distanceFromSun;
    this.orbitalPeriod = orbitalPeriod;
  }

  private _orbit = Math.random();
  get orbit() {
    this._orbit += 24 / this.orbitalPeriod / this.fps;
    return this._orbit;
  }
}