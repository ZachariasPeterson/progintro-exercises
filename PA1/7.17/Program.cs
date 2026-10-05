double input = 1.234; // in meters 
Unit current = Unit.mm;

switch(current) {
    case (Unit.m):
        input *= 1;
        break;
    case (Unit.cm):
        input *= 100;
    break; 
        case (Unit.mm):
        input *= 1000;
        break;
    case (Unit.inch):
        input *=100/2.54;
        break;
    default:
        Console.WriteLine("Desired unit is not available");
        break;
}

enum Unit {
    m,
    cm,
    mm,
    inch,
}

