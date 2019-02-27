import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-cell-duplicate',
  templateUrl: './cell-duplicate.component.html',
  styleUrls: ['./cell-duplicate.component.css'],
  // changeDetection: ChangeDetectionStrategy.OnPush
})
export class CellDuplicateComponent implements OnInit {

  @Input() changeColor: any = false;

  constructor() { }

  ngOnInit() {
  }
  
  ngDoCheck(){
    console.log('Change Detected in duplicate cell');
  }

}
