import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CellDuplicateComponent } from './cell-duplicate.component';

describe('CellDuplicateComponent', () => {
  let component: CellDuplicateComponent;
  let fixture: ComponentFixture<CellDuplicateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CellDuplicateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CellDuplicateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
