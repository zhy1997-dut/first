clear all
clc
seed=1;
retest1=zeros(20,684);
seed_arr=randi([1,1000],20,1);
for i=1:20
    seed=seed_arr(i,1);
    sim("testc1.slx");
    retest1(i,:)=yc1;
end
stairs(tout,retest1')
save retest1.mat retest1;