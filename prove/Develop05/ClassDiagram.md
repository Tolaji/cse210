                    +-----------------------+
                    |       Goal            |
                    +-----------------------+
                    | - goalID: int         |
                    | - description: string |
                    | - points: int         |
                    |-----------------------|
                    | + IsCompleted(): bool |
                    | + RecordEvent(): void |
                    +-----------------------+
                                |
                                |
                                |
                                |
         +--------------------------------------------+                       
         |                                            |
         |                                            |
+-------------------+                       +-------------------+
|    SimpleGoal     |                       |    EternalGoal    |
+-------------------+                       +-------------------+
| - completed: bool |                       |                   |
+-------------------+                       +-------------------+
| + IsCompleted()   |                       | + IsCompleted()   |
| + RecordEvent()   |                       | + RecordEvent()   |
+-------------------+                       +-------------------+
         ^                                            ^
         |                                            |
         |                                            |
         |                                            |
         |                                            |
         |                                            |
+-------------------+            +----------------------------------------+
|  ChecklistGoal    |            |  UserProfile                           |
+-------------------+            +----------------------------------------+
| - targetCount: int|            | - userID: int                          |
| - currentCount: int|           | - userName: string                     |
| - bonusPoints: int|            | - goals: List<Goal>                    |
+-------------------+            | - score: int                           |
| + IsCompleted()   |            +----------------------------------------+
| + RecordEvent()   |            | + AddGoal(Goal)                        |
+-------------------+            | + RecordGoalEvent(int)                 |
                                 | + DisplayGoals()                       |
                                 | + DisplayScore()                       |
                                 | + SaveProfile(string)                  |
                                 | + LoadProfile(string): UserProfile     |
                                 +----------------------------------------+
