# Opgave 1 - Konvertering mellem talsystemer

Dette repository benyttes som entry kriterie for at komme i betragtning til jobsamtale hos Testware.

Opgaven har til formål at vise ansøgerens forståelse for:

- Matematik
- Algoritme programmering
- Test
- Testdesign
- Kodekvalitet
- Kodedesign

## Opgaven

Udvikle en funktion, som kan konvertere fra et talsystem til et andet.

Talsystemerne som det skal kunne håndtere er base-2 til base-25

Løsningen skal desuden teste at følgende er opfyldt.


	TC	Input 		From 	To 		Expected
		Value		base	Base	Value	
	-------------------------------------------------
	#1	234			10		2		11101010
	#2	hlm			24		4		2201032
	#3	110101001	2		10		425
	#4	7454		10		3		101020002
	#5	10352302	6		13		ab302


## Varighed

Ansøger får 6 timer til løsning af opgaven.

----------


# Opgave 2 - Page Object Model og Selenium

Udvikle et funktion, som ved brug af siden https://www.unitconverters.net kan konvertere værdier med enhederne fra Length, Area, Weight og Time.

Løsningen skal desuden teste at følgende er opfyldt.


	TC	Input										Expected 		output
		Convertion	FromValue	FromUnit			ToUnit			ToValue
	------------------------------------------------------------------------------------------------
	#1	Length		31			Yard				Meter			28,3464
	#2	Length		8702,6		Millimeter			Inch			342,5984252
	#3	Area		482,9		Square Millimeter	Square Inch		0,748496497
	#4	Weight		5			Ounce				Gram			141,7475
	#5	Time		3600		Minute				Day				2,5
	------------------------------------------------------------------------------------------------


Det forventes, at Page Object Model er benyttet under implementering.

Det forventes at selenium benyttes. 

Der ses positivt på at koden i øvrigt er hensigtsmæssigt opdelt i klare ansvarsområder.

## Varighed

Ansøger for 3 timer til løsning af opgaven


----------



# Opgave 3 - SOLID Refactoring

Omskriv dette projekt så det følger SOLID principperne.
Kommenter koden og forklar hvorfor at det lige netop her er nødvendigt at omskrive koden.



## Opgace 3.1 SRP Single Responsibility Principle

**Wikipedia**

> The single responsibility principle is a computer programming principle that states that every module or 
> class should have responsibility over a single part of the functionality provided by the software, 
> and that responsibility should be entirely encapsulated by the class. All its services should be 
> narrowly aligned with that responsibility. Robert C. Martin expresses the principle as, 
> "A class should have only one reason to change."[1]


**Opgave**

UserRegistration class håndterere i dag et fuldt flow til user registrering. 
Klassen lider dog under at tage et for stort ansvar.

Udfør en fornuftig refactoring.



## Opgave 3.2 OSP Open/Closed Principle

**Wikipedia**

> In object-oriented programming, the open/closed principle states "software entities (classes, modules, functions, etc.) 
> should be open for extension, but closed for modification";[1] that is, such an entity can allow its behaviour to be 
> extended without modifying its source code.
> The name open/closed principle has been used in two ways. Both ways use inheritance to resolve the apparent 
> dilemma, but the goals, techniques, and results are different.

**Opgave**

AreaCalculator er på nuværende tidspunkt i stand til at beregne det totale areal af et antal rectangler.
Udvid AreaCalculator til også at kunne supportere areal beregning for cirkler og trekanter.


# Opgave 3.3 LSP Liskov substitution principle

** Wikipedia **

> Substitutability is a principle in object-oriented programming stating that, in a computer program, if S is a subtype 
> of T, then objects of type T may be replaced with objects of type S (i.e. an object of type T may be substituted with 
> any object of a subtype S) without altering any of the desirable properties of T (correctness, task performed, etc.). 
> More formally, the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, called (strong) 
> behavioral subtyping, that was initially introduced by Barbara Liskov in a 1987 conference keynote address titled 
> Data abstraction and hierarchy. It is a semantic rather than merely syntactic relation because it intends to guarantee 
> semantic interoperability of types in a hierarchy, object types in particular. Barbara Liskov and Jeannette Wing formulated 
> the principle succinctly in a 1994 paper as follows:
> Subtype Requirement: Let {\displaystyle \phi (x)} \phi (x) be a property provable about objects {\displaystyle x} x of 
> type T. Then {\displaystyle \phi (y)} {\displaystyle \phi (y)} should be true for objects {\displaystyle y} y of type S 
> where S is a subtype of T.
> In the same paper, Liskov and Wing detailed their notion of behavioral subtyping in an extension of Hoare logic, which
> bears a certain resemblance to Bertrand Meyer's design by contract in that it considers the interaction of subtyping 
> with preconditions, postconditions and invariants.

**Opgave**

TextFileManager klassen kan i dag håndtere at gemme indholdet af de filer vi har i listen.
Det viser sig at nogle af disse filer er skrivebeskyttet. 

Omskriv TextFileManageren så den kan håndtere både read/write file og only read filer.





# Opgave 3.4 - ISP Interface segregation principle

** Wikipedia **

> The interface-segregation principle (ISP) states that no client should be forced to depend on methods it does not use.[1] 
> ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about 
> the methods that are of interest to them. Such shrunken interfaces are also called role interfaces.[2] ISP is intended to 
> keep a system decoupled and thus easier to refactor, change, and redeploy. ISP is one of the five SOLID principles of 
> object-oriented design, similar to the High Cohesion Principle of GRASP.[3]

**Opgave**

Director klassen implementer ILead interfacet uagtet at director ikke arbejder med nogen programmeringsopgaver, men han 
tildeler opgaver og uddeler opgaver. Det er derfor et brud på ISP princippet at implementere ILead på Director klassen.

Omskriv klasserne så de følger ISP.



# Opgave 3.5 - Dependency inversion principle

** Wikipedia **

> In object-oriented design, the dependency inversion principle refers to a specific form of decoupling software modules. 
> When following this principle, the conventional dependency relationships established from high-level, policy-setting modules 
> to low-level, dependency modules are reversed, thus rendering high-level modules independent of the low-level module 
> implementation details. The principle states:[1]
> A. High-level modules should not depend on low-level modules. Both should depend on abstractions.
> B. Abstractions should not depend on details. Details should depend on abstractions.
> By dictating that both high-level and low-level objects must depend on the same abstraction this design principle 
> inverts the way some people may think about object-oriented programming.[2]
> The idea behind points A and B of this principle is that when designing the interaction between a high-level module 
> and a low-level one, the interaction should be thought of as an abstract interaction between them. This not only has 
> implications on the design of the high-level module, but also on the low-level one: the low-level one should be designed 
> with the interaction in mind and it may be necessary to change its usage interface.
> In many cases, thinking about the interaction in itself as an abstract concept allows the coupling of the components to be 
> reduced without introducing additional coding patterns, allowing only a lighter and less implementation dependent interaction schema.
> When the discovered abstract interaction schema(s) between two modules is/are generic and generalization makes sense, this 
> design principle also leads to the following dependency inversion coding pattern.


**Opgave**

Implementer skellettet til en logger som sender exception stacktrace til REST API. 
Følg DIP.
