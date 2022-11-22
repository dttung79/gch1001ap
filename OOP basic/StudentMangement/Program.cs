using StudentMangement;

bool running = true;
SchoolProgram program = new SchoolProgram();
while (running)
{
    program.PrintMenu();
    int choice = program.GetChoice();
    program.Process(choice);
    running = choice != 0;
}