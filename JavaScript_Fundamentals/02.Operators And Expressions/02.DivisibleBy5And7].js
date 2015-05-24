var a = 5;
b = 35;

console.log(DevisibleBy5And7(a));
console.log(DevisibleBy5And7(b));


function DevisibleBy5And7(number) {
    if (number % 5 == 0 && number % 7 == 0) {
        return true;
    }
    return false;
}