import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cell',
  templateUrl: './cell.component.html',
  styleUrls: ['./cell.component.css']
})
export class CellComponent implements OnInit {

  changeColor: boolean = false;

  constructor() { }

  ngOnInit() {
  }

  changeBackground(): void {
    this.changeColor = !this.changeColor;
  }

}
