/**
 * Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.
 */


Array.prototype.removeElement = function (param) {
    for(var i = this.length; i--;){
        if (this[i] === param) this.splice(i, 1);
    }
}

var arr = [3,5,3,22,663,11,8,3];
arr.removeElement(3);
console.log(arr);