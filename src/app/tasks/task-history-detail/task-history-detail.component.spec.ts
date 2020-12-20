import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskHistoryDetailComponent } from './task-history-detail.component';

describe('TaskHistoryDetailComponent', () => {
  let component: TaskHistoryDetailComponent;
  let fixture: ComponentFixture<TaskHistoryDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TaskHistoryDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TaskHistoryDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
