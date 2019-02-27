import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-cell',
  templateUrl: './cell.component.html',
  styleUrls: ['./cell.component.css'],
  
})
export class CellComponent implements OnInit {

  @Input() changeColor: any = false;

  constructor() { }

  ngOnInit() {
  }
  
  ngDoCheck(){
    console.log('Change Detected in cell');
  }

}
