using DemoComposite;

Company alibaba = new Company();

ReferenceMember jack = new ReferenceMember("Jack", 100);
jack.Add(new NewMember("Anna", 100));
jack.Add(new NewMember("Lauren", 100));

ReferenceMember mike = new ReferenceMember("Mike", 100);
ReferenceMember tom = new ReferenceMember("Tom", 100);
tom.Add(new NewMember("Laura", 100));
tom.Add(new NewMember("Windy", 100));
mike.Add(tom);

mike.Add(new NewMember("Tim", 100));
mike.Add(new NewMember("Watson", 100));

ReferenceMember paul = new ReferenceMember("Paul", 100);
paul.Add(new NewMember("Henry", 100));

alibaba.AddTopMember(jack);
alibaba.AddTopMember(mike);
alibaba.AddTopMember(paul);

alibaba.Show();
Console.WriteLine("Total income: {0}", alibaba.CalculateIncome());