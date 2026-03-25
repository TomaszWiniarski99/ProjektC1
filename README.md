Opis projektu:
Aplikacja konsolowa, która symuluje działanie uczelnianej wypożyczalni sprzętu. System umożliwia zarządzanie użytkownikami, sprzętem oraz procesem wypożyczeń.
Użytkownik może:
- dodawać nowych użytkowników,
- dodawać sprzęt różnych typów,
- wypożyczać i zwracać sprzęt,
- sprawdzać dostępność sprzętu,
- przeglądać aktywne i przeterminowane wypożyczenia,
- generować raport podsumowujący stan systemu.

Struktura projektu:
Projekt został podzielony na kilka głównych części:
1. Model
Zawiera klasy reprezentujące główne elementy systemu:
- `Person` (abstrakcyjna), `Student`, `Employee`
- `Item` (abstrakcyjna), `Laptop`, `Camera`, `Projector`
- `Renting` – reprezentuje pojedyncze wypożyczenie
2. Logika biznesowa
- `Service` – klasa odpowiedzialna za obsługę operacji systemu (wypożyczenia, zwroty, walidacje, raporty)
3. Uruchomienie
- `Program.cs` – służąca do przetestowania działania systemu

Uzasadnienie decyzji projektowych:
Podział klas i odpowiedzialności
Zastosowałem podział zgodny z odpowiedzialnościami:

- Model odpowiada tylko za przechowywanie danych i podstawowe operacje.
- Service zawiera całą logikę biznesową.
- Program.cs odpowiada wyłącznie wyświetlanie i testy.

Dzięki temu:
- logika nie jest wymieszana z interfejsem,
- kod jest łatwiejszy do rozbudowy i testowania.

Kohezja
Każda klasa ma określoną odpowiedzialność:
- `Person` i jego klasy pochodne przechowują dane użytkownika,
- `Item` i jego klasy pochodne reprezentują sprzęt,
- `Renting` zajmuje się tylko pojedynczym wypożyczeniem,
- `Service` zarządza operacjami systemowymi.
Dzięki temu klasy są spójne i łatwe do zrozumienia.

Coupling
Starałem się ograniczyć zależności między klasami:
- Klasy modelu (`Person`, `Item`) nie znają klasy `Service`,
- `Service` korzysta z modeli, ale nie odwrotnie,
Dzięki temu zmiana jednej części systemu ma minimalny wpływ na inne.

Dziedziczenie
Dziedziczenie zostało użyte tam, gdzie wynika naturalnie z modelu:
- `Student` i `Employee` dziedziczą po `Person`,
- `Laptop`, `Camera`, `Projector` dziedziczą po `Item`.
Pozwala to:
- współdzielić wspólne pola (np. `Id`, `Name`, `Status`),
- jednocześnie rozszerzać klasy o cechy specyficzne.

Reguły biznesowe
Zostały zaimplementowane w klasie `Service`:
- limit wypożyczeń zależny od typu użytkownika,
- brak możliwości wypożyczenia niedostępnego sprzętu,
- kontrola maksymalnego czasu wypożyczenia,
- naliczanie kary za opóźnienie.