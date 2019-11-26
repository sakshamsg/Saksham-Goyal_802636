import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FindtrComponent } from './findtr.component';

describe('FindtrComponent', () => {
  let component: FindtrComponent;
  let fixture: ComponentFixture<FindtrComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FindtrComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FindtrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
