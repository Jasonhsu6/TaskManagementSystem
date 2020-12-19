export interface PendingTask {
    TaskId: number,
    UserId?: number,
    Title?: string,
    Description?: string,
    DueDate?: Date,
    Remarks?: string,
    Priority?: string,
}