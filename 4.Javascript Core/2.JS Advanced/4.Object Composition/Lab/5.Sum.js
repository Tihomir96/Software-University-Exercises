function getModel() {
    let model = {
        init : (sel1,sel2,res) =>{
            model.num1 = $(sel1)
            model.num2 = $(sel2)
            model.result = $(res)
        },
        add : () => model.result.val(+model.num1.val() + +model.num2.val()),
        subtract : () => model.result.val(+model.num1.val() - +model.num2.val())
    }
    return model
}