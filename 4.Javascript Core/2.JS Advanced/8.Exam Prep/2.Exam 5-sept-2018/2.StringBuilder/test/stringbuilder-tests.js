const StringBuilder = require('../stringBuilder')
let expect = require('chai').expect

describe('StringBuilder Unit Tests', function () {
    let sb;
    beforeEach(function () {
        sb = new StringBuilder()
    })
    describe('test if method exists', function () {
        it('append method exist', function () {
            expect(StringBuilder.prototype.hasOwnProperty('append')).to.be.true
        })
        it('pepend method exist',function(){
            expect(Object.getPrototypeOf(sb).hasOwnProperty('prepend')).to.be.true
        })
        it('insertAt method exist',function(){
            expect(Object.getPrototypeOf(sb).hasOwnProperty('insertAt')).to.be.true
        })
        it('remove method exist',function(){
            expect(Object.getPrototypeOf(sb).hasOwnProperty('remove')).to.be.true
        })
        it('toString method exist',function(){
            expect(Object.getPrototypeOf(sb).hasOwnProperty('toString')).to.be.true
        })
    })
    describe('initialize with string or empty',function(){
         it('it should return same string',function(){
            sb = new StringBuilder('asd123')
            expect(sb.toString()).to.be.equal('asd123')
         })
         it('empty string',function(){
             let stringB = new StringBuilder()
             expect(stringB.toString()).to.be.equal('')
         })
    })
    describe('initialize with other types (should throw error)',function(){
        it('test with numbers',function(){
            expect(()=>{sb = new StringBuilder(777)}).to.throw(TypeError)
        })
        it('test with arr',function(){
            expect(()=>{sb = new StringBuilder(['arrayTest'])}).to.throw(TypeError)
        })
    })
    describe('test append method',function(){
        it('should append MurdaBoyz&MBT-sluhove',function(){
            sb.append('MurdaBoyz')
            sb.append('&MBT-')
            sb.append('sluhove')
            expect(sb.toString()).to.be.equal('MurdaBoyz&MBT-sluhove')
        })
        it('should throw error appending array and object',function(){
            expect(()=>{sb.append([]).append({})}).to.throw(TypeError)

        })
    })
    describe('test prepend method',function(){
        it('test if prepend works correctly',function(){
            sb.append('race')
            sb.prepend('car')
            sb.append('Hi')
            sb.prepend('bye')
            expect(sb.toString()).to.be.equal('byecarraceHi')
        })
        it('with mixed types',function(){
            sb.append('Hello, There')
            sb.append('Hell, No')
            expect(()=>{sb.prepend([])}).to.throw(TypeError)
        })
    })

    //No Need to check if index is at range at next two describes
    describe('test insertAt method',function(){
        it('insert Hi at zero index',function(){
            sb.insertAt('Hi',0)
            expect(sb.toString()).to.be.equal('Hi')
        })
        it('insert Hi in the middle of word',function(){
            sb.append('MECHKA')
            sb.insertAt('Hi',2)
            expect(sb.toString()).to.be.equal('MEHiCHKA')
        })
    })
    describe('test remove method',function(){
        it('should remove bira from drinkbira',function(){
            sb.append('drinkbira')
            sb.remove(5,4)
            expect(sb.toString()).to.be.equal('drink')
        })
    })
})