using Mediator;

var manager = new Manager();
var programmer = new Programmer(manager);
var tester = new Tester(manager);
manager.Programmer = programmer;
manager.Tester = tester;
manager.StartWork("ТЗ");