export interface CompletedTask {
    TaskId: number,
    UserId?: number,
    Title?: string,
    Description?: string,
    DueDate?: Date,
    Remarks?: string,
    Completed: Date,
}