const Sumator = require('./Sumator')
let expect = require('chai').expect

describe('Sumator Unit Tests', function () {
    let sumator;
    beforeEach(function () {
        sumator = new Sumator()
    })
    describe('check if functions exists',function(){
        it('data is not undefined',function(){
            expect(sumator.data!==undefined).to.be.true
        })
        it('add func exist',function(){
            expect(Sumator.prototype.hasOwnProperty('add')).to.be.true
        })
        
        it('sumNums func exist',function(){
            expect(Sumator.prototype.hasOwnProperty('sumNums')).to.be.true
        })
        
        it('removeByFilter func exist',function(){
            expect(Sumator.prototype.hasOwnProperty('removeByFilter')).to.be.true
        })
        
        it('toString func exist',function(){
            expect(Sumator.prototype.hasOwnProperty('toString')).to.be.true
        })
    })
    it('test if data arr in empty', function () {
        expect(sumator.data.length).to.be.equal(0, 'something went wrong')
    })

    describe('add func Tests', function () {

        it('add only numbers', function () {
            sumator.add(5)
            sumator.add(4)
            sumator.add(3)
            expect(sumator.toString()).to.be.equal('5, 4, 3')
        })

        it('add only string', function () {
            sumator.add('pesho')
            sumator.add('charli')
            sumator.add('spidaka')
            expect(sumator.toString()).to.be.equal('pesho, charli, spidaka')
        })
        
        it('add only objects', function () {
            sumator.add({}) 
            expect(sumator.toString()).to.be.equal('[object Object]')
        })

        
        it('add mix types', function () {
            sumator.add(4)
            sumator.add('gosho') 
            expect(sumator.toString()).to.be.equal('4, gosho')
        })
    })

    describe('sumNums',function(){
        it('sum only numbers',function(){
            sumator.add(5)
            sumator.add(15)
            sumator.add(20)
            expect(sumator.sumNums()).to.be.equal(40)
        })
        it('sum string,object and numbers',function(){
            sumator.add("gosho")
            sumator.add({chikita:"kude si be"})
            sumator.add(18)
            expect(sumator.sumNums()).to.be.equal(18)
        })
        it('sum strings should return 0', function(){
            sumator.add('gosho')
            sumator.add('pesho')
            expect(sumator.sumNums()).to.be.equal(0)
        })

        
        it('sum arr + object should return 0', function(){
            sumator.add([1,3,5])
            sumator.add({})
            expect(sumator.sumNums()).to.be.equal(0)
        })
        
        it('sum arr + arr should return 0', function(){
            sumator.add([1,3,5])
            sumator.add([1,3,5])
            expect(sumator.sumNums()).to.be.equal(0)
        })

        it('sum object + object should return 0', function(){
            sumator.add({1:2})
            sumator.add({3:4})
            expect(sumator.sumNums()).to.be.equal(0)
        })

    })

    describe('removeByFilter',function(){
        it('remove "2" from "1, 2, 3"',function(){
            sumator.add(1)
            sumator.add(2)
            sumator.add(3)
            sumator.removeByFilter((x)=>x===2)
            expect(sumator.data.join(', ')).to.be.equal("1, 3")
        })

        it('throws exception',function(){
            sumator.add("pesho")
            sumator.add(2)
            sumator.add(3)
            
            expect(() => sumator.removeByFilter(undefined)).to.throw()
        })
        
        
        it('remove string from "pesho", 2, 3',function(){
            sumator.add("pesho")
            sumator.add(2)
            sumator.add(3)
            sumator.removeByFilter((x)=>x==="pesho")
            expect(sumator.data.join(', ')).to.be.equal("2, 3")
        })
        
        
        it('remove where element !== 1 from 1, 1, 3',function(){
            sumator.add(1)
            sumator.add(1)
            sumator.add(3)
            sumator.removeByFilter((x)=>x !=1)
            expect(sumator.data.join(', ')).to.be.equal("1, 1")
        })
    })

    describe('toString function',function(){
        it('with strings in array',function(){
            sumator.add(5)
            sumator.add("Malko kote sex ima li?")
            expect(sumator.toString()).to.be.equal('5, Malko kote sex ima li?')
        })
        it('with {} in array',function(){
            sumator.add(5)
            sumator.add("{}")
            expect(sumator.toString()).to.be.equal('5, {}')
        })
        
        it('with numbers only in array',function(){
            sumator.add(5)
            sumator.add(7)
            expect(sumator.toString()).to.be.equal('5, 7')
        })
    })
})