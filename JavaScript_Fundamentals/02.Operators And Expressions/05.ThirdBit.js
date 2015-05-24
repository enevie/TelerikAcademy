var a = 5, b = 8;

console.log(ReturnBit(a));
console.log(ReturnBit(b));


function ReturnBit(number) {
    return (number >> 3) & 1;
}