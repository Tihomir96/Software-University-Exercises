// let html =document.body.innerHTML =`<body>
//     <div id="wrapper">
//         <input type="text" id="name">
//         <input type="text" id="income">
//     </div>
// </body>
// `

let sharedObject = {
    name: null,
    income: null,
    changeName: function (name) {
        if (name.length === 0) {
            return;
        }
        this.name = name;
        let newName = $('#name');
        newName.val(this.name);
    },
    changeIncome: function (income) {
        if (!Number.isInteger(income) || income <= 0) {
            return;
        }
        this.income = income;
        let newIncome = $('#income');
        newIncome.val(this.income);
    },
    updateName: function () {
        let newName = $('#name').val();
        if (newName.length === 0) {
            return;
        }
        this.name = newName;
    },
    updateIncome: function () {
        let newIncome = $('#income').val();
        if (isNaN(newIncome) || !Number.isInteger(Number(newIncome)) || Number(newIncome) <= 0) {
            return;
        }
        this.income = Number(newIncome);
    }
};
let expect = require('chai').expect
let jsdom = require('jsdom-global')()
let $ = require('jquery')

describe('Shared Object Unit Tests', function () {
    describe('initial value tests', function () {
        it(`test name initial value`, function () {
            expect(sharedObject.name).to.be.null
        })
        it(`test income initial value`, function () {
            expect(sharedObject.income).to.be.null
        })
    })
    describe('Change name test', function () {
        it('with empty string', function () {
            sharedObject.changeName('')
            expect(sharedObject.name).to.be.null
        })
        it('with a non-empty string', function () {
            sharedObject.changeName('non-empty string')
            expect(sharedObject.name).to.be.equal('non-empty string')
        })

        // describe('Name input tests',function(){
        //     it('with empty string', function(){
        //         sharedObject.changeName('Chochko')

        //         sharedObject.changeName('')
        //         let nameTxtVal = $('#name').val()
        //         expect(nameTxtVal.val()).to.be.equal('Chochko')

        //     })
        //     it('with a non-empty string',function(){
        //         sharedObject.changeName('non-empty string')
        //         let nameTxtVal = $('#name').val()                
        //         expect(nameTxtVal.val()).to.be.equal(`non-empty string`)

        //     })  
        // })

    })
    describe('ChangeIncome tests', function () {
        it('with a string (should stay null)', function () {
            sharedObject.changeIncome('d')
            expect(sharedObject.income).to.be.null
        })
        it('with a positive number', function () {
            sharedObject.changeIncome(5)
            expect(sharedObject.income).to.be.equal(5)
        })
        it('with a floating-point ', function () {
            sharedObject.changeIncome(5)
            sharedObject.changeIncome(5.80085)
            expect(sharedObject.income).to.be.equal(5)
        })
        it('with a negative number', function () {
            sharedObject.changeIncome(5)
            sharedObject.changeIncome(-4)
            expect(sharedObject.income).to.be.equal(5)
        })

        it('with zero', function () {
            sharedObject.changeIncome(5)
            sharedObject.changeIncome(0)
            expect(sharedObject.income).to.be.equal(5)
        })

        describe('income input tests'), function () {
            it('with a string (should change correctly)', function () {
                sharedObject.changeIncome(5)
                sharedObject.changeIncome('d')
                let incomeTxt = $('$income')
                expect(incomeTxt.val()).to.be.equal('5', 'income input did not change correctly')
            })
            it('with a positive number', function () {
                sharedObject.changeIncome(5)
                let incomeTxt = $('$income')
                expect(incomeTxt.val()).to.be.equal('5', 'income input did not change correctly')
            })

            it('with a floating-point number', function () {
                sharedObject.changeIncome(5)
                sharedObject.changeIncome(2.11)
                let incomeTxt = $('$income')
                expect(incomeTxt.val()).to.be.equal('5', 'income input did not change correctly')
            })


            it('with a negative number', function () {
                sharedObject.changeIncome(5)
                sharedObject.changeIncome(-2.11)
                let incomeTxt = $('$income')
                expect(incomeTxt.val()).to.be.equal('5', 'income input did not change correctly')
            })


            it('with zero', function () {
                sharedObject.changeIncome(5)
                sharedObject.changeIncome(0)
                let incomeTxt = $('$income')
                expect(incomeTxt.val()).to.be.equal('5', 'income input did not change correctly')
            })    
        }
    })
    describe('Update name tests',function(){
        it('with an empty string')
    })
})
