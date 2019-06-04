clear all
clc
seed=1;
retest2=zeros(20,684);
seed_arr=randi([1,1000],20,1);
t2_arr=30*rand(20,1)+3;
c2_arr=rand(20,1)+0.1;
for i=1:20
    seed=seed_arr(i,1);
    t2=t2_arr(i,1);
    c2=c2_arr(i,1);
    sim("testc2.slx");
    retest2(i,:)=yc2;
end
stairs(tout,retest2')
save retest2.mat retest2;