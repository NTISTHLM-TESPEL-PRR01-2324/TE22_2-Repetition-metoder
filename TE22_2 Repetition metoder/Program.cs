
Utilities.SayAlsoSomethingElse();

int hp = 100;
int strength = 0;

(hp, strength) = SayGoodbye(hp);

(int hp, string name) character = (100, "Micke");


static (int, int) SayGoodbye(int inreHp)
{

  inreHp -= 10;

  Console.WriteLine("Goodbye");

  return (inreHp, 700);
}

// static void SaySomething()
// {
//   SayGoodbye();
// }