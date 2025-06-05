import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'hour'
})
export class HourPipe implements PipeTransform {

  transform(value: number): string {
    if (value == 1)
      return "" + value + " hour"
    else
      return "" + value + " hours"

  }

}
