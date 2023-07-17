function User(name, age) {
    this.name = name;
    this.age = age;
}

var user1 = new User("Player 1", 20);
console.table(user1);

var user2 = new User();
user2.age = 21;
user2.name = "Player 2";
console.table(user2);

User.prototype.report = function() {
    return `Name: ${this.name}, Age: ${this.age}.`
}

console.log(user1.report());
console.log(user2.report());