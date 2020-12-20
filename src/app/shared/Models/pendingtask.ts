export interface PendingTask {
    taskId?: number,
    userId?: number,
    title?: string,
    description?: string,
    dueDate?: Date,
    remarks?: string,
    priority?: string,
}