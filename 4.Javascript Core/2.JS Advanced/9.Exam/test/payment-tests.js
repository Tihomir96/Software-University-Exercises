const PaymentPackage = require('./PaymentPackage')
let expect = require('chai').expect

describe("Payment Package Unit tests", function() {

    let paymentPackage;
    beforeEach(function () {
        paymentPackage = new PaymentPackage('test',2)
    })
    describe('constructor test',function(){
        it('should throw error with only 1 parameter',function(){
            expect(()=>{let pp = new PaymentPackage('name')}).to.throw(Error)
        })
        it('should throw error with only 1 parameter',function(){
            expect(()=>{let pp = new PaymentPackage(3)}).to.throw(Error)
        })
        it('should throw error if 1st param is number and second string',function(){
            expect(()=>{let pp = new paymentPackage(3,'goshkata')}).to.throw(Error)
        })
    })
    describe('Can be instantiated with two parameters – a string name and number value',function(){
        it(' expect name to be name',function(){
            let pp = new PaymentPackage('name',3)
            expect(pp.name).to.be.equal('name')
        })
        it('expect value to be 3',function(){
            let pp = new PaymentPackage('name',3)
            expect(pp.value).to.be.equal(3)
        })
    })
    describe('Accessor name – used to get and set the value of name',function(){
        it('set name to be a number should throw error',function(){
            let pp = new PaymentPackage('name',3)
            expect(()=>{pp.name=3}).to.throw(Error)            
        })
        it('set name with arr of string should throw err',function(){
            let pp = new PaymentPackage('name',3)
            expect(()=>{pp.name=['gosho v array']}).to.throw(Error)
        })
        it('should work correctly with string',function(){
            paymentPackage.name ='gosho'
            expect(paymentPackage.name).to.be.equal('gosho')
        })
        it('should throw err if string length is 0',function(){
            expect(()=>{pp.name=''}).to.throw(Error)
        })
        
        it('should throw err if string length is 0',function(){
            expect(()=>{pp.name={}}).to.throw(Error)
        })
    })
    describe('Accessor value – used to get and set the value of value',function(){
        it('set value to be number should work correctly',function(){
            paymentPackage.value = 3
            expect(paymentPackage.value).to.be.equal(3)
        })
        it('set value to be number should work correctly',function(){
            paymentPackage.value = 0
            expect(paymentPackage.value).to.be.equal(0)
        })
        it('value must not be a negative',function(){
            expect(()=>{paymentPackage.value=-15}).to.throw(Error)
        })
        it('must be a number',function(){
            expect(()=>{paymentPackage.value='string'}).to.throw(Error)
        })
        
        it('must be a number',function(){
            expect(()=>{paymentPackage.value=[]}).to.throw(Error)
        })
        
    })
    describe('Accessor VAT – used to get and set the value of VAT',function(){
        it('set VAT to be number should work correctly',function(){
            paymentPackage.VAT = 3
            expect(paymentPackage.VAT).to.be.equal(3)
        })
        it('value must not be a negative',function(){
            expect(()=>{paymentPackage.VAT=-15}).to.throw(Error)
        })
        it('must be a number',function(){
            expect(()=>{paymentPackage.VAT='string'}).to.throw(Error)
        })

        it('set value to be number should work correctly',function(){
            paymentPackage.VAT = 0
            expect(paymentPackage.VAT).to.be.equal(0)
        })
        
    })
    describe('Accessor active – used to get and set the value of active',function(){
        it('set active to be false should work correctly',function(){
            paymentPackage.active = false
            expect(paymentPackage.active).to.be.false
        })
        it('set active to be true should work correctly',function(){
            paymentPackage.active = true
            expect(paymentPackage.active).to.be.true
        })
        it('set different type to active should throw err',function(){
            expect(()=>{paymentPackage.active='test'}).to.throw(Error)
        })
        
    })
    describe('test if toString exist',function(){
        it('check if toString exist',function(){
            expect(Object.getPrototypeOf(paymentPackage).hasOwnProperty('toString')).to.be.true
        })
    })
    describe('test ToString func',function(){
        it('should work correctly',function(){
            paymentPackage.name = 'gosho'
            paymentPackage.active = false
            paymentPackage.value = 5
            paymentPackage.VAT = 6
            expect(paymentPackage.toString()).to.be.equal(`Package: gosho (inactive)\n- Value (excl. VAT): 5\n- Value (VAT 6%): 5.300000000000001`)
        })
        it('should work correctly',function(){
            paymentPackage.name = 'gosho'
            paymentPackage.active = true
            paymentPackage.value = 5
            paymentPackage.VAT = 6
            expect(paymentPackage.toString()).to.be.equal(`Package: gosho\n- Value (excl. VAT): 5\n- Value (VAT 6%): 5.300000000000001`)
        })
        it('should work correctly',function(){
            paymentPackage.name = 'gosho'
            paymentPackage.active = true
            paymentPackage.value = 5
            paymentPackage.VAT = 6
            expect(paymentPackage.toString()).to.be.equal(`Package: gosho\n- Value (excl. VAT): 5\n- Value (VAT 6%): 5.300000000000001`)
        })
        it('test without all params',function(){
            expect(paymentPackage.toString()).to.be.equal('Package: test\n- Value (excl. VAT): 2\n- Value (VAT 20%): 2.4')
        })
    })
 
});
