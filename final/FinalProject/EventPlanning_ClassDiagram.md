                                            +-----------------------+
                                            |      Address          |
                                            +-----------------------+
                                            | - street: string      |
                                            | - city: string        |
                                            | - state: string       |
                                            | - zipCode: string     |
                                            +-----------------------+
                                            | + Address(string,     |
                                            |            string,    |
                                            |           string,     |
                                            |           string)     |
                                            | + ToString(): string  |
                                            +-----------------------+

                                                        ^
                                                        |
                                                        |
                                            +---------------------------+
                                            |      Event                |
                                            +---------------------------+
                                            | - title: string           |
                                            | - description: string     |
                                            | - date: DateTime          |
                                            | - time: string            |
                                            | - address: Address        |
                                            +---------------------------+
                                            | + Event(string,           |
                                            |            string,        |
                                            |            DateTime,      |
                                            |            string,        |
                                            |            Address)       |
                                            | + GetStandardDetails():   | 
                                            |                string     |
                                            | + GetFullDetails():       |
                                            |                string     |
                                            | + GetShortDescription():  |
                                            |                string     |
                                            +---------------------------+
                                                        ^
                                                        |
                                                        |
                                                        |
                +---------------------------------------+-----------------------------------+
                |                                       |                                   |
+-------------------------------+           +-----------------------+      +--------------------------------+
|      Lecture                  |           |     Reception         |      |  OutdoorGathering              |
+-------------------------------+           +-----------------------+      +--------------------------------+
| - speaker: string             |           | - rsvpEmail: string   |      | - weatherForecast: string      |
| - capacity: int               |           +-----------------------+      +-------------------------------+
+-------------------------------+           | + Reception(string,   |      | + OutdoorGathering(string,     |
| + Lecture(string, string,     |           |            string,    |      |                    string,     |
|   DateTime, string, Address,  |           |            DateTime,  |      |                    DateTime,   |
|   string, int)                |           |            string,    |      |                    string,     |
| + GetFullDetails(): string    |           |            Address,   |      |                    Address,    |
+-------------------------------+           |            string)    |      |                    string)     |
                                            | + GetFullDetails():   |      | + GetFullDetails(): string     |
                                            |            string     |      +--------------------------------+
                                            +-----------------------+             
                                            


