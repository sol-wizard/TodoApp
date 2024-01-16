import { Component, OnInit } from '@angular/core';
import { TodoItemDTO } from '../model/todo-item';
import { TodoListService } from '../services/todo-list.service';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrl: './todo-list.component.scss'
})
export class TodoListComponent implements OnInit{
  todoItems : TodoItemDTO[] = [];

  constructor(private todoListService : TodoListService){
  }

  ngOnInit(): void {
    // this.todoItems = this.todoListService.getTodoList();

    this.todoListService.getTodoList().subscribe(
      (todoItems : TodoItemDTO[]) =>{
      this.todoItems = todoItems;
    });
  }
}
