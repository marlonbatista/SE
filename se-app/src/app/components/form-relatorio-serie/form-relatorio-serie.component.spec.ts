import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormRelatorioSerieComponent } from './form-relatorio-serie.component';

describe('FormRelatorioSerieComponent', () => {
  let component: FormRelatorioSerieComponent;
  let fixture: ComponentFixture<FormRelatorioSerieComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormRelatorioSerieComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormRelatorioSerieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
