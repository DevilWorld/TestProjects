import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-super-child',
  templateUrl: './super-child.component.html',
  styleUrls: ['./super-child.component.css']
})
export class SuperChildComponent implements OnInit {

  @Input() propSuperChild: boolean;

  constructor() { }

  ngOnInit() {
  }

  ngDoCheck() {
    console.log('Change detected in super child');
  }

}
