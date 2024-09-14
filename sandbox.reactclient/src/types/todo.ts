export default interface Todo {
	id: number,
	title: string,
	description: string,
	isDone: boolean,
	createdDate: Date,
	completedDate: Date
}