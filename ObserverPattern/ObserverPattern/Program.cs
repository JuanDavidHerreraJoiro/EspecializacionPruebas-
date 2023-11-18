// See https://aka.ms/new-console-template for more information
using ObserverPattern.Observer;

var subject = new Subject();

var slack = new Slack();
subject.Subscribe(slack);

var email = new Email();
subject.Subscribe(email);

subject.Unsubscribe(email);

subject.Notify("Buenas noches");
