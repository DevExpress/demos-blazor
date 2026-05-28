namespace Figures {
    export abstract class Figure {
        private name: string;

        constructor(name: string) {
            this.name = name;
        }

        public abstract draw();
        public abstract square(): number;
        public print() {
            console.log(this.name);
        }
    }
    export class Rectangle extends Figure {
        private width: number;
        private height: number;

        constructor(width: number, height: number) {
            super("Rectangle");
            this.width = width;
            this.height = height;
        }

        public draw() {
            //draw rectangle
        }
        public square(): number {
            return this.width * this.height;
        }
    }
    export class Circle extends Figure {
        private radius: number;

        constructor(radius: number) {
            super("Circle");
            this.radius = radius;
        }

        public draw() {
            //draw circle
        }
        public square(): number {
            return Math.PI * Math.pow(this.radius, 2);
        }
    }
}