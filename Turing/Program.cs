
int currentState = 1;

Turing turing = new Turing(1000, "(()))))))");


while (true)
{

	switch (currentState)
	{
			//find last ")" and put x on it
		case 1:
			findLastParantice();
			break;
			//find first "(" and put y on it
		case 2:
			findFirstParantice();
			break;
			// check all parantice is correct
		case 3:
			checkAllParanticeIsOK();
			break;
		//resolve all x and y
        case 4:
            ResolveAllXandY();
            break;
        //put ")" in the end
        case 5:
            putCloseParanticeInEnd();
            break;
    //6,7,8 handle if "(" is not found!!
        case 6:
            findLastCloseParatice();
            break;
        case 7:
            oneStateComebacke();
            break;
        case 8:
            oneStateComebackeChangeParantice();
            break;


        case -1:
                break;
    }
    if (currentState == -1)
        break;
}
turing.showInput();

void oneStateComebacke()
{
    turing.GoLeft(turing.getHead());
    currentState = 8;
}

void oneStateComebackeChangeParantice()
{
    turing.GoLeft('(');

    turing.GoRight(turing.getHead());
    currentState = 5;
}

void findLastCloseParatice()
{
    if (turing.getHead() == 'x' || turing.getHead() == 'y')
    {
        turing.GoRight(turing.getHead());
        return;
    }
    currentState = 7;
}

void findLastParantice()
{
	if (!turing.getHead().Equals(')'))
	{
		if (turing.getHead().Equals('\0'))
		{
            turing.GoLeft(turing.getHead());
            currentState = 3;
			return;
		}
		turing.GoRight(turing.getHead());
        return;
	}
	turing.GoLeft('x');

	currentState = 2;
}



void findFirstParantice(){

    if (turing.getHead().Equals('\0'))
    {
        turing.GoRight(turing.getHead());
        currentState = 6;
        return;
    }

    if (!turing.getHead().Equals('('))
    {
        turing.GoLeft(turing.getHead());
        return ;
    }
    turing.GoRight('y');
	currentState = 1;
}

void checkAllParanticeIsOK()
{
    //while (true)

    //{ 
        if (turing.getHead().Equals('('))
        {
            currentState = 5;
            return;
        }
        if (turing.getHead().Equals('\0'))
        {
            turing.GoRight(turing.getHead());
            currentState = 4;
            return;
        }
        turing.GoLeft(turing.getHead());
        return;
    //}
}

void ResolveAllXandY()
{
    
    if (!turing.getHead().Equals('\0'))
    {
        if (turing.getHead().Equals('x'))
        {
            turing.GoRight(')');
        }
        else if (turing.getHead().Equals('y'))
        {

            turing.GoRight('(');
        }
        return;
    }
    currentState = -1;
}

 void putCloseParanticeInEnd()
{
    if (!turing.getHead().Equals('\0'))
    {
        turing.GoRight(turing.getHead());
        return;
    }
    turing.GoLeft(')');
    currentState = 1;
 }