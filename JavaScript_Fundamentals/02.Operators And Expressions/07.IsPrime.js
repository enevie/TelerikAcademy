//Write an expression that checks if given positive integer number n (n ? 100) is prime.

var number = 5, a = 37, b = 4;

console.log(isPrime(number));
console.log(isPrime(a));
console.log(isPrime(b));


function isPrime(number) {
    if (number == 1) return false;
    if (number == 2)return true;

    if (number % 2 == 0) return false;

    for (var i = 3; i < number; i += 2) {
        if (number % i == 0) {
            return false;
        }
    }
    return true;
}