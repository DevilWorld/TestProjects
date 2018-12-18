import { Component } from '@angular/core';
import { DialogService } from './dialog/dialog.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angularDynamicComponents';

  constructor(private dialogService: DialogService){

  }

  ngOnInit(){
    this.dialogService.appendDialogComponentToBody();
  }
}
