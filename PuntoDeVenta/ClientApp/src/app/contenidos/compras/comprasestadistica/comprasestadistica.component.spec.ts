import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ComprasestadisticaComponent } from './comprasestadistica.component';

describe('ComprasestadisticaComponent', () => {
  let component: ComprasestadisticaComponent;
  let fixture: ComponentFixture<ComprasestadisticaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ComprasestadisticaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ComprasestadisticaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
