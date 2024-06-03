+-------------------+                +-------------------+
|     Comment       |                |       Video       |
+-------------------+                +-------------------+
| - Name: string    | 1           *  | - Title: string   |
| - Text: string    |----------------| - Author: string  |
+-------------------+                | - Length: int     |
| + Comment(name: string, text: string)   | - comments: List<Comment> |
| + ToString(): string                       +-------------------+
+-------------------+                        | + Video(title: string,  |
                                             |   author: string, length: int)|
                                             | + AddComment(comment: Comment) |
                                             | + GetNumberOfComments(): int  |
                                             | + DisplayInfo(): void         |
                                             +-------------------+
                                                     |
                                                     |
                                                     v
                                             +-------------------+
                                             |      Program      |
                                             +-------------------+
                                             | + Main(args: string[]): void |
                                             +-------------------+
