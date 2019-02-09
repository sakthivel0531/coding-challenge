import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoanSubHeaderComponent } from './loan-sub-header.component';

describe('LoanSubHeaderComponent', () => {
  let component: LoanSubHeaderComponent;
  let fixture: ComponentFixture<LoanSubHeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoanSubHeaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoanSubHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
