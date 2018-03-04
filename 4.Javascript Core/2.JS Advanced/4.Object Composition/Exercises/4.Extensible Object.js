function getExtensibleObject() {
    let obj = {
        extend: function (template) {
            for (const key in template) {
                if (template.hasOwnProperty(key)) {
                    const element = template[key];
                    if (typeof element === 'function') {
                        obj.__proto__[key] = element
                    } else {
                        obj[key] = element
                    }
                }
            }

        }
    }
    return obj

}