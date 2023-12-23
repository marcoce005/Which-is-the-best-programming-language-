fn main() {
    let mut count = 0;

    while count < 1000 {
        println!("{:?}", count);
        count += 1;
    }
}

// rustc .... nome file -o rust.out 