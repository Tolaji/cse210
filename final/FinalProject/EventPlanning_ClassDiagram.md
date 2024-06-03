+--------------------+
|      Address       |
+--------------------+
| - street: string   |
| - city: string     |
| - state: string    |
| - zipCode: string  |
+--------------------+
| + Address(string, string, string, string) |
| + ToString(): string |
+--------------------+

           ^
           |
           |
+--------------------+
|      Event         |
+--------------------+
| - title: string    |
| - description: string |
| - date: DateTime   |
| - time: string     |
| - address: Address |
+--------------------+
| + Event(string, string, DateTime, string, Address) |
| + GetStandardDetails(): string |
| + GetFullDetails(): string     |
| + GetShortDescription(): string|
+--------------------+
           ^
           |
           |
+--------------------+          +--------------------+         +--------------------+
|      Lecture      |          |     Reception      |         |  OutdoorGathering  |
+--------------------+          +--------------------+         +--------------------+
| - speaker: string  |          | - rsvpEmail: string|         | - weatherForecast: string|
| - capacity: int    |          +--------------------+         +--------------------+
+--------------------+          | + Reception(string, string, DateTime, string, Address, string) |
| + Lecture(string, string,     | + GetFullDetails(): string       | + OutdoorGathering(string, string, DateTime, string, Address, string)|
|   DateTime, string, Address,  +--------------------+             | + GetFullDetails(): string  |
|   string, int)                +                                 +--------------------+
| + GetFullDetails(): string    |
+--------------------+
