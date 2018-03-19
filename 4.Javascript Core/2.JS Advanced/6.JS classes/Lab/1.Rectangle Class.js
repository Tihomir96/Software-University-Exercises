class Rectangle {
    constructor(width,height,color){
        [this._width,this._height,this._color] = [width,height,color]
    }
    calcArea(){
        return this._width * this._height
    }
}