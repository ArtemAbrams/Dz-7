using DZ_7;
using Tasks;
// Abstract Factory
/*ICarFactory carFactory = new ToyotaFactory();
Car myCar = carFactory.CreateCar();
myCar.Info();
Engine myEngine = carFactory.CreateEngine();
myEngine.GetPower();
carFactory = new FordFactory();
myCar = carFactory.CreateCar();
myCar.Info();
myEngine = carFactory.CreateEngine();
myEngine.GetPower();
carFactory = new MercedezFactory();
myCar = carFactory.CreateCar();
myCar.Info();
myEngine = carFactory.CreateEngine();
myEngine.GetPower();*/

//Pizza builder
/*Waiter waiter = new Waiter();
PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();
waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
waiter.ConstructPizza();
Pizza pizza = waiter.GetPizza();
pizza.Info();
waiter.SetPizzaBuilder(spicyPizzaBuilder);
waiter.ConstructPizza();
pizza = waiter.GetPizza();
pizza.Info();
waiter.SetPizzaBuilder(margaritaPizzaBuilder);
waiter.ConstructPizza();
pizza = waiter.GetPizza();
pizza.Info();*/

// Mediator
/*ConcreteMediator m = new ConcreteMediator();
ConcreteMediator2 m2 = new ConcreteMediator2();
ConcreteColleague1 c1 = new ConcreteColleague1(m);
ConcreteColleague2 c2 = new ConcreteColleague2(m);
ConcreteColleague3 c3 = new ConcreteColleague3(m2);
m.Colleague1 = c1;
m.Colleague2 = c2;
m2.Colleague3 = c3;
m.Send("How are you?", c1);
m.Send("Fine, thanks", c2);
Console.WriteLine();
c2 = new ConcreteColleague2(m2);
c1 = new ConcreteColleague1(m2);
m2.Colleague1 = c1;
m2.Colleague2 = c2;
c3.Send("Hello");
c2.Send("Hi how are you?");
c1.Send("Hi bro");*/

//Decorate
/*Tree tree = new ChristmasTree("town");
ToysDecorate toysDecorate = new ToysDecorate(tree);
toysDecorate.SetDecorations("toys");
toysDecorate.SetDecorations("russian children");
GarlandDecorate garlandDecorate = new GarlandDecorate(toysDecorate);
garlandDecorate.Beatify();*/

//Prototype
/*IFigure figure = new Rectangle(10, 20);
IFigure clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();
figure = new Circle(15);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();
figure = new Triangle(11, 12, 15);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();*/

// Factory Method
/*Factory factory = new T800Factory();
Terminator terminator = factory.Create();
terminator.Info();
factory = new T1000Factory();
terminator = factory.Create();
terminator.Info();*/

//Apapter
IAirTransport airTransport = new Plane();
Pilot pilot = new Pilot();
pilot.Flight(airTransport);
CrashTheAirTransport adapter = new CrashTheAirTransport(new MilitaryParachute());
pilot.Flight(adapter);

