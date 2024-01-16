import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TodoItemDTO } from '../model/todo-item';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoListService {
  private baseUrl = 'http://localhost:5068/';

  constructor(private httpClient : HttpClient) { }

  getTodoList(): Observable<TodoItemDTO[]>{
    return this.httpClient.get<TodoItemDTO[]>(`${this.baseUrl}api/Todo/getWorkTasks`);
  }
}
