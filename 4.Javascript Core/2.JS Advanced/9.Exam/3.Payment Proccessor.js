class PaymentProcessor {
    constructor(optParam) {
        this.options = this.setOptions(optParam)
        this.payments = []
    }
    get options() {
        return this._options
    }
    set options(value) {
       // this.setOptions(value)
    }
    registerPayment(id, name, type, value) {
        this._validateIdAndName(id)
        this._validateIdAndName(name)
        if(typeof value !=='number'){
            throw new Error('value must be a number')
        }
        let payment = { id: id , Name: name, Type: type, Value: value  }
        if(!this._options.types.includes(type)){
            throw new Error(`invalid type`)
        }
        if(this.payments.find(x=>x.id===id)){
            throw new Error('Can not add elements with an id wich already exists')
        }

        this.payments.push(payment)
    }
    _validateIdAndName(value) {
        if (typeof value !== ('string')) {
            throw new Error('Invalid ID/name')
        }
        if (value.length === 0) {
            throw new Error('ID/name can not be empty')
        }

    }

    get(id) {
        if (!this.payments.find(x=>x.id===id)) {
            throw new Error(`ID not found`)
        }
        let payment = this.payments.find(x=>x.id===id)
        return `Details about payment ID: ${payment.id}\n- Name: ${payment.Name}\n- Type: ${payment.Type}\n- Value: ${payment.Value.toFixed(this._options.precision)}`
        
    }
    deletePayment(id) {
        if (!this.payments.find(x=>x.id===id)) {
            throw new Error(`ID not found`)
        }
        this.payments = this.payments.filter(x=>x.id!==id)
        this.payments
    }
    setOptions(value) {
        this._options = {
            types: ["service", "product", "other"],
            precision: 2
          }
          if(value!==undefined){
            if('types' in value){
                this._options.types =value.types
                this._options.precision = 2
            }
            if('precision' in value){
                this._options.types = ["service", "product", "other"]
                this._options.precision =value.precision
            }
            if(('precision'in value)&&('types' in value)){
                this._options.types =value.types
                this._options.precision = value.precision
            }
          }
            }
    toString() {
        let totalVal = 0
        for (const payment of this.payments) {
            totalVal += Number(payment.Value)
        }
        return `Summary:\n- Payments: ${this.payments.length}\n- Balance: ${totalVal.toFixed(this.options.precision)}`
    }
}
let generalPayments = new PaymentProcessor()
generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);
generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);