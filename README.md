<h1>State Pattern Logger Application</h1>

Tato aplikace ukazuje, jak integrovat novou analytickou knihovnu do existujícího projektu používajícího interface ILogger bez nutnosti refaktorovat volání <code>Log()</code> v celém kódu.

Používáme State pattern, který umožňuje runtimově měnit chování logování a adaptovat cizí API na stávající rozhraní.

<h2>Proč State pattern?</h2>
<ul>
  <li><b>Žádné změny existujícího kódu:</b> aplikace pořád volá <code>ILogger.Log()</code></li>
  <li><b>Dynamická výměna logování:</b> přepínání mezi legacy loggerem a analytikou</li>
  <li><b>Izolace změn:</b> adaptace třetí strany je zapouzdřena ve vlastní třídě</li>
  <li><b>Rozšiřitelnost:</b> nové logovací strategie se jednoduše implementují</li>
</ul>

<h2>Alternavtivní vzory</h2>
<ul>
  <li><b>Adapter Pattern:</b> přemostí rozdílná rozhraní, ale méně flexibilní při dynamickém přepínání</li>
  <li><b>Strategy Pattern:</b> umožňuje výměnu logovacích algoritmů, ale neumí efektivně zachovat stav</li>
</ul>

State pattern kombinuje adaptaci a dynamickou výměnu logiky, což je pro naše potřeby nejvhodnější.
