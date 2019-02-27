import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CellComponent } from './cell/cell.component';
import { CellDuplicateComponent } from './cell-duplicate/cell-duplicate.component';
import { ChildComponent } from './child/child.component';
import { SuperChildComponent } from './super-child/super-child.component';

@NgModule({
  declarations: [
    AppComponent,
    CellComponent,
    CellDuplicateComponent,
    ChildComponent,
    SuperChildComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
