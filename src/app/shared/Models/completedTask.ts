export interface CompletedTask {
    taskId: number,
    userId?: number,
    title?: string,
    description?: string,
    dueDate?: Date,
    remarks?: string,
    completed: Date,
}