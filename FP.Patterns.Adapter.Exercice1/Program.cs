using FP.Patterns.Adapter.Exercice1.Adapters;
using FP.Patterns.Adapter.Exercice1.ExternalAPIs;

GermanSystem germanSystem = new GermanSystem();
SpanishSystem spanishSystem = new SpanishSystem();
EnglishSystem englishSystem = new EnglishSystem();

IPaySystemAdapter germanAdapter = new GermanSystemAdapter(germanSystem);
IPaySystemAdapter spanishAdapter = new SpanishSystemAdapter(spanishSystem);
IPaySystemAdapter englishAdapter = new EnglishSystemAdapter(englishSystem);

germanAdapter.Pay();
germanAdapter.Verify();
germanAdapter.Refund();
Console.WriteLine("------------");
spanishAdapter.Pay();
spanishAdapter.Verify();
spanishAdapter.Refund();
Console.WriteLine("------------");
englishAdapter.Pay();
englishAdapter.Verify();
englishAdapter.Refund();
