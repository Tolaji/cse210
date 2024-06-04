                        +------------------------------------+
                        |            Activity                |
                        +------------------------------------+
                        | - date: DateTime                   |
                        | - duration: int                    |
                        +------------------------------------+
                        | + Activity(date: DateTime,         |
                        |   duration: int)                   |
                        | + Date: DateTime                   |
                        | + Duration: int                    |
                        | + GetDistance(): double            |  <-- Abstract method
                        | + GetSpeed(): double               |  <-- Abstract method
                        | + GetPace(): double                |  <-- Abstract method
                        | + GetSummary(): string             |  <-- Virtual method
                        +------------------------------------+
                                            ^
                                            |
                +---------------------------+--------------------------+
                |                           |                          |
        +-----------------+     +---------------------+     +-------------------+
        |  Running        |     |   Cycling           |     |  Swimming         |
        +-----------------+     +---------------------+     +-------------------+
        | - distance:     |     | - speed:            |     | - laps:           |
        |   double        |     |   double            |     |   int             |
        +-----------------+     +---------------------+     +-------------------+
        | + Running(date: |     | + Cycling(date:     |     | + Swimming        |
        |   DateTime,     |     |   DateTime,         |     |   (date:          |
        |   duration: int,||    |   duration: int,    |     |   DateTime        |
        |   distance:     |     |   speed: double)    |     |   duration:       |
        |   double)       |     |                     |     |   int, laps:      |
        |                 |     |                     |     |   int)            |
        | + GetDistance():|     | + GetDistance():    |     | + GetDistance():  |
        |   double        |     |   double            |     |   double          |
        | + GetSpeed():   |     | + GetSpeed():       |     | + GetSpeed():     |
        |   double        |     |   double            |     |   double          |
        | + GetPace():    |     | + GetPace():        |     | + GetPace():      |
        |   double        |     |   double            |     |   double          |
        | + GetSummary(): |     | + GetSummary():     |     | + GetSummary():   |
        |   string        |     |   string            |     |   string          |
        +-----------------+     +---------------------+     +-------------------+

