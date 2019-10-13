import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EstadisticaventaComponent } from './estadisticaventa.component';

describe('EstadisticaventaComponent', () => {
  let component: EstadisticaventaComponent;
  let fixture: ComponentFixture<EstadisticaventaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EstadisticaventaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EstadisticaventaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
