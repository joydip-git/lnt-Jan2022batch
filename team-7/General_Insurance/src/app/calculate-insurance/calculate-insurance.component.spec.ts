import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculateInsuranceComponent } from './calculate-insurance.component';

describe('CalculateInsuranceComponent', () => {
  let component: CalculateInsuranceComponent;
  let fixture: ComponentFixture<CalculateInsuranceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CalculateInsuranceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CalculateInsuranceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
