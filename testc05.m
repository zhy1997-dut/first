clear all
clc
seed=1;
retest4=zeros(20,684);
seed_arr=randi([1,1000],20,1);
t5_arr=30*rand(100,1)+3;
for i=1:20
    seed=seed_arr(i,1);
    t5=t5_arr(i,1);
    sim("testc5.slx");
    retest4(i,:)=yc4;
end

stairs(tout,retest4')
save retest4.mat retest4;