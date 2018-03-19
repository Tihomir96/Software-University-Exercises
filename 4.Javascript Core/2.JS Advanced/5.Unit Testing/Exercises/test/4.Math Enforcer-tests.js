let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};
//tests
let expect = require('chai').expect
describe('Math Enforcer Unit Tests', function () {
    describe('addFive', function () {
        it('with a string (should return undefined)', function () {
            let result = mathEnforcer.addFive('blqks')
            expect(result).to.be.undefined
        })
        it('with positive number (should return number+5)', function () {
            let result = mathEnforcer.addFive(5)
            expect(result).to.be.equal(10,'5+ 5 =10 on addFive func')
        })
        it('with negative number',function(){
            let result = mathEnforcer.addFive(-4)
            expect(result).to.be.equal(1)
        })
        it('with floating point number',function(){
            let result = mathEnforcer.addFive(3.14)
            expect(result).to.be.closeTo(8.14,0.01)
        })        
    })
    describe('subtractTen', function () {
        it('with a string (should return undefined)', function () {
            let result = mathEnforcer.subtractTen('blqks')
            expect(result).to.be.undefined
        })
        it('with positive number (should return number - 10)', function () {
            let result = mathEnforcer.subtractTen(20)
            expect(result).to.be.equal(10,'20-10 =10 on subtractTen func')
        })
        it('with negative number',function(){
            let result = mathEnforcer.subtractTen(-4)
            expect(result).to.be.equal(-14)
        })
        it('with floating point number',function(){
            let result = mathEnforcer.subtractTen(15.5)
            expect(result).to.be.equal(5.5)
        })        
    })
    describe('sum',function(){
        it('first num as a string(should return undefined)', function(){
            let result = mathEnforcer.sum('p',2)
            expect(result).to.be.undefined
        })
        it('second num as a string(should return undefined)', function(){
            let result = mathEnforcer.sum(2,'p')
            expect(result).to.be.undefined
        })
        it('with negative number',function(){
            let result = mathEnforcer.sum(-4,-4)
            expect(result).to.be.equal(-8)
        })
        it('with two positive numbers (should return correct sum)',function(){
            expect(mathEnforcer.sum(5,5)).to.be.equal(10)
        })
        it('with two floating-point numbers',function(){
            let result =mathEnforcer.sum(5.05,5.06) 
            expect(result).to.be.equal(10.11,'Sum didnt return correct value')
        })
    })
})