import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormRelatorioTurmaComponent } from './form-relatorio-turma.component';

describe('FormRelatorioTurmaComponent', () => {
  let component: FormRelatorioTurmaComponent;
  let fixture: ComponentFixture<FormRelatorioTurmaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormRelatorioTurmaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormRelatorioTurmaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
