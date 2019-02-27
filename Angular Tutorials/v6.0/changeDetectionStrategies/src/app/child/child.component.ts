import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ChildComponent implements OnInit {

  @Input() propChild: boolean;

  constructor() { }

  ngOnInit() {
  }

  ngDoCheck(){
    console.log('Change Detected in child');
  }

}
